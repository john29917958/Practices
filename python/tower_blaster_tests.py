import unittest
import tower_blaster

class TestTowerBlasterMethods(unittest.TestCase):
    def test_computer_play(self):
        tower = [3, 1, 10]
        main_pile = [4, 5, 6]
        discard_pile = [7, 8, 9]
        tower = tower_blaster.computer_play(tower, main_pile, discard_pile)
        self.assertGreater(tower[1], tower[0], 'Asserts the bricks are well sorted in ascending order.')
        self.assertGreater(tower[2], tower[1], 'Asserts the bricks are well sorted in ascending order.')

if __name__ == '__main__':
    unittest.main()
