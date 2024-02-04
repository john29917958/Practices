import random
from textwrap import dedent


def print_instructions():
    print('New round starts')


def computer_move(computer_score, human_score):
    score = roll()
    if score == 6:
        return 0

    print(f'Computer got {score}')
    should_roll_again = random.randint(0, 1)
    while should_roll_again:
        dice_num = roll()
        if dice_num == 6:
            return 0

        print(f'Computer got {dice_num}')
        score += dice_num
        should_roll_again = random.randint(0, 1)

    return score


def human_move(computer_score, human_score):
    score = roll()
    if score == 6:
        return score
    print(f'You got {score}')

    while ask_yes_or_no('Roll again?'):
        dice_num = roll()
        if dice_num == 6:
            print('You rolled a 6. You get 0 point in this round.')
            return 0

        print(f'You got {dice_num}')
        score += dice_num

    return score


def is_game_over(computer_score, human_score):
    if human_score >= 50 or computer_score >= 50:
        if computer_score == human_score:
            return False
        else:
            return True

    return False


def roll():
    return random.randint(1, 6)


def ask_yes_or_no(prompt):
    prompt += ' (Y/N)'
    user_input = input(prompt)
    while len(user_input) == 0 or (user_input.lower()[0] != 'y' and user_input.lower()[0] != 'n'):
        print('invalid input')
        user_input = input(prompt)

    user_input = user_input.replace(' ', '')
    if user_input.lower()[0] == 'y':
        return True
    elif user_input.lower()[0] == 'n':
        return False
    else:
        return False # Ask again...


def show_current_status(computer_score, human_score):
    print(dedent(f"""
        Your score is: {human_score}
        Computer's score is: {computer_score}
        You are {'ahead' if human_score > computer_score else 'behind'} the computer by {abs(human_score - computer_score)} points"""))


def show_final_results(computer_score, human_score):
    score_diff = abs(computer_score - human_score)
    if human_score > computer_score:
        print(f'You win computer by {score_diff} points')
    elif computer_score == human_score:
        print(f'Draw')
    else:
        print(f'You lose computer by {score_diff} points')


def main():
    computer_score = 0
    human_score = 0
    is_playing = True
    is_game_ended = False

    while is_playing:
        is_game_ended = False
        while not is_game_ended:
            print_instructions()
            human_score += human_move(computer_score, human_score)
            computer_score += computer_move(computer_score, human_score)
            show_current_status(computer_score, human_score)
            is_game_ended = is_game_over(computer_score, human_score)
            if is_game_ended:
                show_final_results(computer_score, human_score)
        is_playing = ask_yes_or_no('Want to play again?')


if __name__ == '__main__':
    main()
