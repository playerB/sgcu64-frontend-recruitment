import os

def clear():
    os.system('cls')

def printByRow(display):
    for i in range(0, 3) :
        print(digits[display[0]][i], digits[display[1]][i], digits[display[2]][i], digits[display[3]][i], digits[display[4]][i], digits[display[5]][i])

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
    'space' : [' __ ', ' __ ', ' __ ']
}

displayNum = [1,2,3,4,5,6]

timer = input().split(':')
intTimer = [int(n) for n in timer]

if (intTimer[1] > 59 or intTimer[2] > 59) :
    print('Error')

else :
    printByRow(displayNum)



