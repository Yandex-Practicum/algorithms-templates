# ! change LOCAL to False before submitting !
# set LOCAL to True for local testing

LOCAL = True

if LOCAL:
    class Node:  
        def __init__(self, value, left=None, right=None):  
            self.value = value  
            self.right = right  
            self.left = left


def solution(root) -> bool:
    #  Your code
    #  “ヽ(´▽｀)ノ”
    pass


def test():
    node1 = Node(3,  None,  None)
    node2 = Node(4,  None,  None)
    node3 = Node(4,  None,  None)
    node4 = Node(3,  None,  None)
    node5 = Node(2, node1, node2)
    node6 = Node(2, node3, node4)
    node7 = Node(1, node5, node6)
    assert solution(node7)

if __name__ == '__main__':
    test()