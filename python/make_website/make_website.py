import sys


def surround_block(tag, text):
    return f'<{tag}>{text}</{tag}>'


def create_email_link(email_address):
    return f'<a href="{email_address}">{email_address.replace("@", "[aT]")}</a>'


def read_resume(file_path):
    lines = []
    with open(file_path, 'r') as resume_file:
        for line in resume_file:
            lines.append(line)
    return lines


def get_name(lines):
    tokens = lines[0].split(' ')
    for token in tokens:
        if not token[0].isupper():
            return 'Invalid Name'
    return lines[0].strip()


def get_email(lines):
    for line in lines:
        if '@' in line:
            return line.strip()
    return ''


def get_courses(lines):
    for line in lines:
        line = line.strip()
        if not line.startswith('Courses'):
            continue
        start_idx = line.index(':-') + 2
        line = line[start_idx:]
        line = line.strip()
        tokens = line.split(',')
        for i in range(len(tokens)):
            tokens[i] = tokens[i].strip()
        return tokens
    return []


def get_projects(lines):
    is_proj_line_starts = False
    projects = []
    for i in range(len(lines)):
        line = lines[i].strip()
        if line.startswith('Projects'):
            is_proj_line_starts = True
        elif line.startswith('----------'):
            return projects
        elif is_proj_line_starts and line:
            projects.append(line)
        else:
            pass  # Do nothing.
    return projects


def generate_html(txt_input_file, html_output_file):
    data_lines = read_resume(txt_input_file)
    template_html_line_pos = 0
    with open('resume_template.html', 'r') as template_html_file, open(html_output_file, 'w') as resume_file:
        if not data_lines: # Source data is empty.
            resume_file.write('')
            return
        while True:
            template_line = template_html_file.readline()
            if len(template_line) == 0:  # Invalid resume template.
                return

            body_tag_start_idx = template_line.find('<body')
            if body_tag_start_idx == -1:
                resume_file.write(template_line)
            else:
                html = ''
                body_tag_end_idx = template_line.find('>', body_tag_start_idx)
                while body_tag_end_idx == -1:
                    html += template_line
                    template_line = template_html_file.readline()
                    if len(template_line) == 0:  # Invalid resume template.
                        return
                    body_tag_end_idx = template_line.find('>')
                html = template_line[body_tag_start_idx:body_tag_end_idx + 1]
                resume_file.write(html)
                template_html_line_pos = body_tag_end_idx + 1
                break

        name = get_name(data_lines)
        email = get_email(data_lines)
        projects = get_projects(data_lines)
        courses = get_courses(data_lines)
        projects_html = ''
        for project in projects:
            projects_html += surround_block('li', project)
        html = '\n' + surround_block('div',
            '\n' +
            surround_block('div',
                '\n' +
                surround_block('h1', name) + '\n' +
                surround_block('p', 'Email: ' + create_email_link(email)) + '\n'
            ) + '\n' +
            surround_block('div',
                '\n' +
                surround_block('h2', 'Projects') + '\n' +
                surround_block('ul', projects_html) + '\n'
            ) + '\n' +
            surround_block('div',
                '\n' +
                surround_block('h3', 'Courses') + '\n'
            ) + '\n' +
            surround_block('span', ', '.join(courses)) + '\n'
        ) + '\n'
        resume_file.write(html)

        if template_html_line_pos < len(template_line):
            template_line = template_line[template_html_line_pos:].strip()
            if template_line:
                resume_file.write(template_line + '\n')
        while True:
            template_line = template_html_file.readline()
            if len(template_line) == 0:
                break
            resume_file.write(template_line)


if __name__ == '__main__':
    data_file_path = sys.argv[1]
    output_file_path = sys.argv[2]
    generate_html(data_file_path, output_file_path)
