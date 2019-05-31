import heapq

nums = [1, 8, 23, 7, -4, 18, 23, 42, 37, 2]
print("用 heapq.nlargest 找 nums, {}, 裡最大的3員: {}".format(nums, heapq.nlargest(3, nums)))
print("用 heapq.nsmallest 找 nums, {}, 裡最小的3員: {}".format(nums, heapq.nsmallest(3, nums)))

heap = nums.copy()
heapq.heapify(heap)
print("use heapq.heapify to sort num, {} -> {}".format(nums, heap))

print("實作Priority Queue")

class PriorityQueue:
    def __init__(self):
        self._queue = []
        self._index = 0

    def push(self, item, priority):
        heapq.heappush(self._queue, (-priority, self._index, item))
        self._index += 1

    def pop(self):
        return heapq.heappop(self._queue)[-1]

class Item:
    def __init__(self, name):
        self._name = name

    def __repr__(self):
        return "Item({!r})".format(self._name)


q = PriorityQueue()

q.push(Item("Foo"), 1)
q.push(Item("bar"), 2)
q.push(Item("spam"), 4)
q.push(Item("grok"), 1)

print(q.pop())
print(q.pop())
print(q.pop())
print(q.pop())



