import sys
from collections import Counter
N = int(sys.stdin.readline())
arr = []
for i in range(N):
    arr.append(int(sys.stdin.readline()))
arr.sort()
Count_arr = Counter(arr).most_common()
print(round(sum(arr)/N))
print(arr[N//2])
if len(Count_arr) > 1:
    if Count_arr[0][1] == Count_arr[1][1]:
        print(Count_arr[1][0])
    else:
        print(Count_arr[0][0])
else:
    print(Count_arr[0][0])
print(arr[-1]-arr[0])
    