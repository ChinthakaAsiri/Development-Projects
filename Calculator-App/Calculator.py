from tkinter import *
root = Tk()
root.title("Chinthaka Calculator")

#Input here
inp_1 = Entry(root, width=50,borderwidth=5)
inp_1.grid(row=0, column=0,columnspan=3, padx=5, pady=15)

#Functions here

def number(num):
    numn = str(inp_1.get())
    inp_1.delete(0, END)
    fnum1 = numn + str(num)
    inp_1.insert(0, fnum1)

def button_click(num):
    if num <10 :
        global n1
        global s1
        number(num)
    elif num == 11:
        s1 = "+"
        n1=inp_1.get()
        inp_1.delete(0,END)
        number("")
    elif num==12:
        s1 = "-"
        n1=inp_1.get()
        inp_1.delete(0,END)
        number("")
    elif num==13:
        s1 = "x"
        n1 = inp_1.get()
        inp_1.delete(0, END)
        number("")
    elif num==14:
        s1 = "/"
        n1 = inp_1.get()
        inp_1.delete(0, END)
        number("")
    elif num==15:
        inp_1.delete(0,END)
    elif num ==16:
        global n2
        n2=inp_1.get()
        inp_1.delete(0,END)
        if s1=="+":
            x = int(n1)+int(n2)
            inp_1.insert(0,x)
        elif s1=="-":
            x = int(n1)-int(n2)
            inp_1.insert(0,x)
        elif s1=="x":
            x = int(n1)*int(n2)
            inp_1.insert(0, x)
        elif s1=="/":
            x = int(n1)/int(n2)
            inp_1.insert(0, x)
        else:
            inp_1.insert(0, "Enter Valid number and operator")

#Buttons here

button_1 = Button(root, text = " 1 ", command = lambda: button_click(1),padx=40, pady=20)
button_2 = Button(root, text = " 2 ", command = lambda: button_click(2),padx=40, pady=20)
button_3 = Button(root, text = " 3 ", command = lambda: button_click(3),padx=40, pady=20)
button_4 = Button(root, text = " 4 ", command = lambda: button_click(4),padx=40, pady=20)
button_5 = Button(root, text = " 5 ", command = lambda: button_click(5),padx=40, pady=20)
button_6 = Button(root, text = " 6 ", command = lambda: button_click(6),padx=40, pady=20)
button_7 = Button(root, text = " 7 ", command = lambda: button_click(7),padx=40, pady=20)
button_8 = Button(root, text = " 8 ", command = lambda: button_click(8),padx=40, pady=20)
button_9 = Button(root, text = " 9 ", command = lambda: button_click(9),padx=40, pady=20)
button_0 = Button(root, text = " 0 ", command = lambda: button_click(0),padx=40, pady=20)

button_add = Button(root, text=" + ", padx=92,pady=20, command = lambda: button_click(11))
button_sub = Button(root, text=" - ", padx=40,pady=15, command = lambda: button_click(12))
button_mul = Button(root, text=" x ", padx=40,pady=15, command = lambda: button_click(13))
button_dev = Button(root, text=" / ", padx=40,pady=15, command = lambda: button_click(14))
button_clr = Button(root, text=" C ", padx=38,pady=15, command = lambda: button_click(15))
button_sum = Button(root, text=" = ", padx=94,pady=15, command = lambda: button_click(16))

button_7.grid(row=1, column=0)
button_8.grid(row=1, column=1)
button_9.grid(row=1, column=2)
button_4.grid(row=2, column=0)
button_5.grid(row=2, column=1)
button_6.grid(row=2, column=2)
button_1.grid(row=3, column=0)
button_2.grid(row=3, column=1)
button_3.grid(row=3, column=2)
button_0.grid(row=4, column=0)

button_add.grid(row=4, column=1, columnspan=2)
button_sub.grid(row=5, column=0)
button_mul.grid(row=5, column=1)
button_dev.grid(row=5, column=2)
button_clr.grid(row=6, column=0)
button_sum.grid(row=6, column=1, columnspan=2)

root.mainloop()