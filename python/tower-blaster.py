import random
from shutil import ExecError


def setup_bricks():
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
        discard_pile.append(main_pile[0])
        del main_pile[0]


def check_tower_blaster(tower):
    for i in range(0, len(tower) - 1):
        if tower[i] > tower[i + 1]:
            return False
    return True


def get_top_brick(brick_pile):
    if brick_pile:
        top_brick = brick_pile[0]
        del brick_pile[0]
        return top_brick
    else:
        return None


def deal_initial_bricks(main_pile):
    tower_pc = []
    tower_player = []

    for i in range(10):
        tower_pc.append(main_pile[0])
        del main_pile[0]
        tower_player.append(main_pile[0])
        del main_pile[0]

    return (tower_pc, tower_player)


def add_brick_to_descard(brick, discard_pile):
    discard_pile.insert(0, brick)
    pass


def find_and_replace(new_brick, brick_to_be_replaced, tower, discard_pile):
    try:
        index_brick_to_be_replaced = tower.index(brick_to_be_replaced)
        replaced_brick = tower[index_brick_to_be_replaced]
        tower[index_brick_to_be_replaced] = new_brick
        add_brick_to_descard(replaced_brick, discard_pile)
        return True
    except ValueError:
        return False


def computer_play(tower, main_pile, discard_pile):
    pass


def main():
    piles = setup_bricks()
    shuffle_bricks(piles[0])
    towers = deal_initial_bricks(piles[0])
    """
    find_and_replace(get_top_brick(piles[0]), towers[0][0], towers[0], piles[1])
    check_bricks(piles[0], piles[1])
    print(piles)
    """


if __name__ == '__main__':
    main()
