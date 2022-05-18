# Comment it before submitting
# class Node:  
#     def __init__(self, value, left=None, right=None):  
#         self.value = value  
#         self.right = right  
#         self.left = left

    
def solution(root1, root2):
    #  Your code
    #  “ヽ(´▽｀)ノ”
    pass


def test():
    node1 = Node(1,  None,  None)
    node2 = Node(2,  None,  None)
    node3 = Node(3,  node1,  node2)

    node4 = Node(1, None,  None)
    node5 = Node(2, None, None)
    node6 = Node(3, node4, node5)
    
    assert solution(node3, node6)
