str1 = "tes"
slen = len(str1)
for i in range(slen):
    j = i + 1
    for v in range(j, slen):
        if str1[v] == str1[i]:
            print("dup found")
