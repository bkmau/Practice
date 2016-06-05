"""
Say you have an array for which the ith element is the price of a given stock on day i.

If you were only permitted to complete at most one transaction (ie,
buy one and sell one share of the stock), design an algorithm to find the maximum profit.

問題：

假設你有一個陣列，該陣列第 i 個元素代表第 i 天股票的價格，並且你指有一次買賣的機會，請設計一個演算法求得最大的力論為何？

例子

股市 = {3, 2, 6, 5, 0, 3},
則最大利潤為 4 (第二天買進 第三天賣出)
股市 = { 2, 1 },
則最大利潤為 0 (因為買了一定賠)
"""


list = [3, 2, 6, 5, 6, 1, 2, 6, 1]

list2 = [x - max(list) for x in list]

maxIndex = 0
for i, j in enumerate(list2):
    if j == 0:
        if i > maxIndex:
            maxIndex = i

print("To earn the best profit, {}, of stock, as buy at day {} and sell at day {}".format(
    abs(min(list2[0:maxIndex])), list2.index(min(list2[0:maxIndex])) + 1, maxIndex + 1
))
