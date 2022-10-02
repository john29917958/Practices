import shutil
import sys
from xml.etree.ElementInclude import include


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
    if not data_lines:
        with open(html_output_file, 'w') as resume_file:
            resume_file.write('')
        return
    name = get_name(data_lines)
    email = get_email(data_lines)
    projects = get_projects(data_lines)
    courses = get_courses(data_lines)

    projects_html = ''
    for project in projects:
        projects_html += surround_block('li', project)

    shutil.copy2('resume_template.html', html_output_file)
    is_in_body_tag = False
    html = ''
    with open(html_output_file, 'r+') as resume_file:
        for line in resume_file:
            if '<body' in line:
                is_in_body_tag = True
                html += line
            elif '</body' in line:
                is_in_body_tag = False
                html += line
            else:
                if is_in_body_tag:
                    html += surround_block('div',
                        surround_block('div',
                            surround_block('h1', name) + '\n' +
                            surround_block('p', 'Email: ' + create_email_link(email))
                        ) + '\n' +
                        surround_block('div',
                            surround_block('h2', 'Projects') + '\n' +
                            surround_block('ul', projects_html)
                        ) + '\n' +
                        surround_block('div',
                            surround_block('h3', 'Courses')
                        ) + '\n' +
                        surround_block('span',
                            ', '.join(courses)
                        )
                    )
                else:
                    html += line
        resume_file.write(html)


if __name__ == '__main__':
    data_file_path = sys.argv[1]
    output_file_path = sys.argv[2]
    generate_html(data_file_path, output_file_path)
