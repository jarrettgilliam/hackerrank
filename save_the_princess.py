#!/bin/python
# Head ends here
def displayPathtoPrincess(n,grid):
    # get my location
    me = [n/2, n/2]
    
    # get princess location
    for r in grid:
        if 'p' in r:
            princess = [r.index('p'), grid.index(r)]
            break
    
    while me != princess:
        # Move left or right
        if me[0] < princess[0]:
            print "RIGHT"
            me[0] += 1
        elif me[0] > princess[0]:
            print "LEFT"
            me[0] -= 1
        # Move up or down    
        if me[1] < princess[1]:
            print "DOWN"
            me[1] += 1
        elif me[1] > princess[1]:
            print "UP"
            me[1] -= 1
     
#print all the moves here
# Tail starts here
m = input()

grid = []
for i in xrange(0, m): 
    grid.append(raw_input().strip())

displayPathtoPrincess(m,grid)
