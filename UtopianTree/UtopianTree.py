#!/usr/bin/python

x = 0
T = int(raw_input())
N = []

while x < T:
  N.append(int(raw_input()))
  x+=1

for x in N:
  height = 1
  for y in range(0, x):
    if y%2 == 1:
      height += 1
    else:
      height *= 2
  print height
