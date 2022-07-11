def merge(arr, lf, mid, rg):
	# Your code
	# “ヽ(´▽｀)ノ”
	pass


def merge_sort(arr, lf, rg):
	# Your code
	# “ヽ(´▽｀)ノ”
	pass

def test():
	a = [1, 4, 9, 2, 10, 11]
	b = merge(a, 0, 3, 6)
	expected = [1, 2, 4, 9, 10, 11]
	assert b == expected
	c = [1, 4, 2, 10, 1, 2]
	merge_sort(c, 0 , 6)
	expected = [1, 1, 2, 2, 4, 10]
	assert c == expected

if __name__ == '__main__':
    test()