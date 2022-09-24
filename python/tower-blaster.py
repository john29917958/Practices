import random


def setup_bricks():
    # Initializes the list with list comprehension.
    main_pile = [i for i in range(1, 61)]
    discard_pile = []
    return (main_pile, discard_pile)


def shuffle_bricks(bricks):
    random.shuffle(bricks)


def check_bricks(main_pile, discard_pile):
    if not main_pile and discard_pile:
        random.shuffle(discard_pile)
        main_pile.extend(discard_pile)
        discard_pile.clear()
        discard_pile.append(main_pile.pop(0))


def check_tower_blaster(tower):
    for i in range(0, len(tower) - 1):
        if tower[i] > tower[i + 1]:
            return False
    return True


def get_top_brick(brick_pile):
    if brick_pile:
        return brick_pile.pop(0)
    else:
        return None


def deal_initial_bricks(main_pile):
    tower_pc = []
    tower_player = []

    for i in range(10):
        tower_pc.append(main_pile.pop(0))
        tower_player.append(main_pile.pop(0))

    return (tower_pc, tower_player)


def add_brick_to_discard(brick, discard_pile):
    discard_pile.insert(0, brick)
    pass


def find_and_replace(new_brick, brick_to_be_replaced, tower, discard_pile):
    try:
        index_brick_to_be_replaced = tower.index(brick_to_be_replaced)
        replaced_brick = tower[index_brick_to_be_replaced]
        tower[index_brick_to_be_replaced] = new_brick
        add_brick_to_discard(replaced_brick, discard_pile)
        return True
    except ValueError:
        return False


def computer_play(tower, main_pile, discard_pile):
    top_brick = discard_pile.pop(0)
    for i in range(len(tower) - 1):
        if tower[i] > tower[i + 1] and top_brick < tower[i + 1]:
            if find_and_replace(top_brick, tower[i], tower, discard_pile):
                print(f'Vikings picked {top_brick} from the discard pile')
                print(f'Vikings replaced a brick')
                return tower
            else:
                discard_pile.insert(0, top_brick)

    top_brick = main_pile.pop(0)
    print(f'Vikings picked {top_brick} from the main pile')
    for i in range(len(tower) - 1):
        if tower[i] > tower[i + 1] and top_brick < tower[i + 1]:
            if find_and_replace(top_brick, tower[i], tower, discard_pile):
                print(f'Vikings replaced a brick')
                return tower
    add_brick_to_discard(top_brick, discard_pile)
    return tower


def main():
    # The first item is the main pile, the second item is the discard pile.
    piles = setup_bricks()
    shuffle_bricks(piles[0])
    # The first item is the pc's tower, the second item is the player's tower.
    towers = deal_initial_bricks(piles[0])
    add_brick_to_discard(piles[0].pop(0), piles[1])

    while True:
        print('Vikings\' tower looks:', towers[0])
        computer_play(towers[0], piles[0], piles[1])
        print("Vikings' turn is over")

        print('Your tower now looks:', towers[1])        

        if check_tower_blaster(towers[0]):
            print('Sorry, you lost.')
            print('Your tower: ', towers[1])
            print('Vikings\' tower: ', towers[0])        
            user_input = input('Do you want to play again? [Y/n]: ')
            if user_input.to_lower() == 'y' or len(user_input.strip()) == 0:
                continue
            else:
                print('Game ends.')
                break
        
        check_bricks(piles[0], piles[1])
        print(
            f'(1) The width of the top brick on the discard pile is: "{piles[1][0]}"')
        print('(2) The width of the mystery brick is: "*"')
        print()
        user_input = None
        brick = None
        while True:  # Choose a brick in player's turn.
            user_input = input(
                'Select the building brick you want to use (1/2):')
            if user_input == "1":  # Choose the top brick on the discard pile.
                brick = get_top_brick(piles[1])
                break
            elif user_input == "2":  # Choose the top brick on the main pile.
                brick = get_top_brick(piles[0])
                while True:  # User chooses to use it.
                    user_input = input(
                        f'The width of the brick is: {brick}. Do you want to use this building brick? (Y: Yes/N: Discard and skip turn):')
                    if user_input.lower() == "y":
                        break
                    elif user_input.lower() == "n":  # User choses to discard it.
                        add_brick_to_discard(brick, piles[1])
                        brick = None
                        break
                    else:
                        print('Invalid command.')
                break
            else:
                print('Invalid command.')
        if brick != None:
            while True:
                user_input = input(
                    'Please enter the brick you want to replace: ')
                try:
                    user_input = int(user_input)
                    if (find_and_replace(brick, user_input, towers[1], piles[1])):
                        break
                    else:
                        print('The brick you entered is not found in your tower.')
                except ValueError:
                    print('Invalid input.')
        if check_tower_blaster(towers[1]):
            print('You won!')
            print('Your tower: ', towers[1])
            print('Vikings\' tower: ', towers[0])
            user_input = input('Do you want to play again? [Y/n]: ')
            if user_input.lower() == 'y' or len(user_input.strip()) == 0:
                check_bricks(piles[0], piles[1])
            else:
                print('Game ends.')
                break


if __name__ == '__main__':
    main()
