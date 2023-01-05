from typing import Optional


# ! Do not change Node class !
class Node:
    def __init__(self, left=None, right=None, value=0):
        self.right = right
        self.left = left
        self.value = value


def remove(root, key) -> Optional["Node"]:
    #  Your code
    #  “ヽ(´▽｀)ノ”
    ...


def test():
    node1 = Node(None, None, 2)
    node2 = Node(node1, None, 3)
    node3 = Node(None, node2, 1)
    node4 = Node(None, None, 6)
    node5 = Node(node4, None, 8)
    node6 = Node(node5, None, 10)
    node7 = Node(node3, node6, 5)
    new_head = remove(node7, 10)
    assert new_head.value == 5
    assert new_head.right is node5
    assert new_head.right.value == 8


if __name__ == '__main__':
    test()
