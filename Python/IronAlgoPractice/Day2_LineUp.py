"""
假設有一間超級好吃的麵包店，每次買東西都要排隊排很久，
但是老闆又不願意大家一大早就來排隊。於是乎老闆就想出了一個方法，
讓不是只有最前面的人才能買的到麵包，也不是排後面就一定買不到。

可以買到麵包的方式如下：
每個排隊的人都會有一個號碼牌，假設有 N 個人排隊，那麼號碼排就是從 1 一直到 N
接者會亂數取一個當作開始的號碼 s 和間隔的號碼 i 以及總共要可以買到麵包的人數 t
因此，就是有 N 個人在排隊，從號碼 s 開始算（含s）每隔 i 個人取一人，總共取 t 人
如果遇到最後，就再從頭算起

舉個例子來說：
有十個人在排隊 1 2 3 4 5 6 7 8 9 10
從第 2 個人開始每隔 4 個人取一人，共取 5 位。
則，選取到的幸運兒就是 [2 6 10 5 1]
"""

num_of_cus = 15
start_no = 8
every_pass_person_picked = 3
total_person_picked = 9

line = ["" for x in range(num_of_cus)]

index = start_no
line[start_no - 1] = "*"
total_person_picked -= 1
j = 1
result = str(start_no) + ","

while total_person_picked != 0:
    if j == every_pass_person_picked:
        if line[index] != "*":
            j = 1
            line[index] += "*"
            result += str(index + 1) + ","
            total_person_picked -= 1
    else:
        if line[index] != "*":
            j += 1
    if index == (len(line) - 1):
        index = 0
    else:
        index += 1

print(line)
print(result)
