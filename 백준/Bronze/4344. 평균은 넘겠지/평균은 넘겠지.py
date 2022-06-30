N = int(input())
for i in range (N):
    M = list(map(int, input().split()))
    meanM = sum(M[1:])/M[0]
    result = 0
    for j in range(1,len(M)):
        if M[j]>meanM:
            result += 1
    print(f'{result/M[0]*100:.3f}%')