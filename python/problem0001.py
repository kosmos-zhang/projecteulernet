print (sum(range(3, 1000, 3)) + sum(range(5, 1000, 5)) - sum(range(15, 1000, 15)))  #233168

print (sum({x for x in range(1000) if x % 3 == 0 or x % 5 == 0}))    #233168
