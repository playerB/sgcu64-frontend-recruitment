import os

digits = {
    0 : [' __ ', '|  |', '|__|'],
    1 : ['    ', '   |', '   |'],
    2 : [' __ ', ' __|', '|__ '],
    3 : [' __ ', ' __|', ' __|'],
    4 : ['    ', '|__|', '   |'],
    5 : [' __ ', '|__ ', ' __|'],
    6 : [' __ ', '|__ ', '|__|'],
    7 : [' __ ', '   |', '   |'],
    8 : [' __ ', '|__|', '|__|'],
    9 : [' __ ', '|__|', ' __|'],
    -1 : ['    ', '    ', ' __ ']
}

justColon = ['   ', ' . ', ' . ']

def clear():
    os.system('cls')

def printByRow(display):
    for i in range(0, 3) :
        print(digits[display[0]][i], digits[display[1]][i], justColon[i], digits[display[2]][i], digits[display[3]][i], justColon[i], digits[display[4]][i], digits[display[5]][i])

displayNum = [1,1,1,1,1,1]
displayEmpty = [-1,-1,-1,-1,-1,-1]

clockInput = input()
timer = clockInput.split(':')
try : 
    intTimer = [int(n) for n in timer]
    
    displayNum = [int(c) for c in clockInput if c != ':']

    if (intTimer[1] > 59 or intTimer[1] < 0 or intTimer[2] > 59 or intTimer[2] < 0 or len(timer[1]) < 2 or len(timer[2]) < 2) :
        #clear()
        printByRow(displayEmpty)

    else :
        printByRow(displayNum)
        
except :
    printByRow(displayEmpty)