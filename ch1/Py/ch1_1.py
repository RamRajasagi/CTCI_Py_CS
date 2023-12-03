# unique
str1 = "world"
str2 = "hello"
i = 0
j = i + 1
slen = len(str1)

while i < slen:
    while j < slen - 1:
        x = str1[i]
        y = str1[j]

        if x == y:
            print("dup")
            break
        else:
            j += 1
    i += 1
    j = i + 1
