# import necessary lib
import os
import winsound
from time import sleep

# a dict collection of seven segments display for each digits representation
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

# colon separator in seven segment display
justColon = ['   ', ' . ', ' . ']

# clear cli
def clear():
    os.system('cls')

# print rows of seven segment display one by one
def printByRow(display):
    for i in range(0, 3) :
        print(digits[display[0]][i], digits[display[1]][i], justColon[i], digits[display[2]][i], digits[display[3]][i], justColon[i], digits[display[4]][i], digits[display[5]][i])

# countdown timer, starts from intTimer time
def countdown(intTimer) :
    hr, mi, se = [n for n in intTimer]
    while (hr >= 0) :
        while (mi >= 0) :
            while (se >= 0) :
                # show seven segment display
                displayNum = [hr // 10, hr % 10, mi // 10, mi % 10, se // 10, se % 10]
                clear()
                printByRow(displayNum)
                sleep(1)
                se -= 1
            se = 59
            mi -= 1
        mi = 59
        hr -= 1
    # sound and message notification when timer ends
    winsound.Beep(555, 3000)
    print("\n\nข้อความอัตโนมัติ : ฮ่า ฮ่า ฮ่าาา !! เจ้าพวกผู้กอบกู้ ! ระเบิดเวลาได้ทำงานแล้ว !")
    sleep(3)
    print("\nแผ่นดินทั้ง 7 จะถูกแยกออกจากกัน และพวกแกก็จะต้องติดอยู่ที่นี่ตลอดไปปปป ฮ่า ฮ่า ฮ่าาา !!")

displayNum = [] # store number display
displayEmpty = [-1,-1,-1,-1,-1,-1] # empty number display

clockInput = input()
timer = clockInput.split(':')
try : 
    # check if the input is correctly formatted
    intTimer = [int(n) for n in timer]
    
    displayNum = [int(c) for c in clockInput if c != ':']

    if (intTimer[1] > 59 or intTimer[1] < 0 or intTimer[2] > 59 or intTimer[2] < 0 or len(timer[1]) < 2 or len(timer[2]) < 2) :
        clear()
        printByRow(displayEmpty)

    else :
        # initiate countdown timer
        countdown(intTimer)

except :
    # show empty display if the input is not correctly formatted
    printByRow(displayEmpty)
