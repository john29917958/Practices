import unittest
import tower_blaster

class TestTowerBlasterMethods(unittest.TestCase):
    def test_computer_play_takes_discard_brick_and_does_replacement(self):
        tower = [3, 1, 10]
        main_pile = [4, 5, 6]
        discard_pile = [7, 8, 9]
        tower = tower_blaster.computer_play(tower, main_pile, discard_pile)
        self.assertGreater(tower[1], tower[0], 'Test computer takes brick from discard pile and does bricks replacement.')
        self.assertGreater(tower[2], tower[1], 'Test computer takes brick from discard pile and does bricks replacement.')
    def test_computer_play_takes_mystery_brick_and_does_replacement(self):
        tower = [3, 1, 10]
        main_pile = [7, 1]
        discard_pile = [2, 4]
        tower = tower_blaster.computer_play(tower, main_pile, discard_pile)
        self.assertGreater(tower[1], tower[0], 'Test computer takes mystery brick and does bricks replacement.')
        self.assertGreater(tower[2], tower[1], 'Test computer takes mystery brick and does bricks replacement.')
    

if __name__ == '__main__':
    unittest.main()
