from cmath import nan
import re


def import_expenses(expenses, file):
    with open(file, 'r') as f:
        for line in f:
            if not line or not line.strip():
                continue
            match = re.match(
                '^(\w[\w\s]*)\s*:\s*(\d*\.?\d+|\d+\.?\d*)$', line.strip())
            if not match:
                continue
            expense_type = match.group(1)
            money = match.group(2)
            add_expense(expenses, expense_type, money)


def get_expense(expenses, expense_type):
    if expense_type in expenses:
        money = expenses[expense_type]
        print(f'{expense_type}: {money}.')
        return money
    else:
        print(f'The expense type "{expense_type}" does not exist.')
        return None


def add_expense(expenses, expense_type, value):
    expense_type = expense_type.strip()
    if not expense_type in expenses:
        expenses[expense_type] = 0
    expenses[expense_type] += float(value) if '.' in value else int(value)
    print(f'{expense_type}: {expenses[expense_type]}')


def deduct_expense(expenses, expense_type, value):
    value = float(value) if '.' in value else int(value)
    if not expense_type in expenses:
        print(f'The expense {expense_type} does not exist.')
        return
    if expenses[expense_type] < value:
        raise RuntimeError(
            'The value is greater than the existing total of the expense type.')
    expenses[expense_type] -= value


def update_expense(expenses, expense_type, value):
    if not expense_type in expenses:
        print(f'The expense {expense_type} does not exist.')
    expenses[expense_type] = value


def sort_expenses(expenses, sorting):
    if sorting != 'expense_type' and sorting != 'amount':
        print('Sorting type should either be "expense_type" or "amount".')
        return None
    expense_list = list(expenses.items())
    expense_list.sort(reverse=True if sorting == 'amount' else False,
                      key=lambda exp: exp[0] if sorting == 'expense_type' else exp[1])
    return expense_list


def export_expenses(expenses, expense_types, file):
    with open(file, 'w') as f:
        for expense_type in expense_types:
            expense_type = expense_type.strip()
            print(expense_type)
            if expense_type in expenses:
                f.write(f'{expense_type}: {expenses[expense_type]}\n')


def main():
    expenses = {}
    import_expenses(expenses, 'input')
    import_expenses(expenses, 'input2')
    option = None
    while option != '0':
        option = input("""
1: Get expense info
2: Add an expense
3: Deduct an expense
4: Update an expense
5: Sort expenses
6: Export expenses
0: Exit the system
""")
        match option:
            case '0':
                print('Bye.')
            case '1':
                expense_type = input('Expense type?')
                get_expense(expenses, expense_type)
            case '2':
                expense_type = input('Expense type: ')
                if not expense_type:
                    print('Invalid expense type')
                else:
                    amount = input('Expense amount: ')
                    if not amount:
                        print('Invalid expense amount')
                    else:
                        add_expense(expenses, expense_type, amount)
            case '3':
                expense_type = input('Expense type: ')
                if not expense_type:
                    print('Invalid expense type')
                else:
                    amount = input('Amount: ')
                    if not amount:
                        print('Invalid amount')
                    else:
                        deduct_expense(expenses, expense_type, amount)
            case '4':
                expense_type = input('Expense type: ')
                if not expense_type:
                    print('Invalid expense type')
                else:
                    amount = input('Amount: ')
                    if not amount:
                        print('Invalid amount')
                    else:
                        update_expense(expenses, expense_type, amount)
            case '5':
                sortBy = input('Sort by: ')
                if not sortBy:
                    print('Invalid input')
                else:
                    sort_expenses(expenses, sortBy)
            case '6':
                expense_types = []
                user_input = None
                while user_input != 'N':
                    user_input = input(
                        'Enter expense type or N to confirm and export the expenses: ')
                    if not user_input or not user_input.strip():
                        print('Input is empty')
                    elif user_input == 'N':
                        output_file_name = input(
                            'Please enter the name of the output file: ')
                        if not output_file_name or not output_file_name.strip():
                            print('Invalid input')
                        else:
                            export_expenses(
                                expenses, expense_types, output_file_name)
                    else:
                        expense_types.append(user_input)
            case _:
                print('Invalid input')


if __name__ == '__main__':
    main()
