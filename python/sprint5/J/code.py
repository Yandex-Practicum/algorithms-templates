# ! change LOCAL to False before submitting !
# set LOCAL to True for local testing

LOCAL = True

if not LOCAL:
    from node import Node

if LOCAL:
    class Node:  
        def __init__(self, left=None, right=None, value=0):  
            self.right = right
            self.left = left
            self.value = value


def insert(root, key):
    #  Your code
    #  “ヽ(´▽｀)ノ”
    pass


def test():
    node1 = Node(None, None, 7)
    node2 = Node(node1, None, 8)
    node3 = Node(None, node2, 7)
    new_head = insert(node3, 6)
    assert new_head is node3
    assert new_head.left.value == 6

if __name__ == '__main__':
    test()