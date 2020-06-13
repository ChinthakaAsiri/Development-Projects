from tkinter import*
import requests
import json


root = Tk()
#root.iconbitmap('icon.ico')
root.title("SL Covid-19 Data")
root.geometry("425x325")

try:
    api_data=requests.get("https://www.hpb.health.gov.lk/api/get-current-statistical")
    api_json=json.loads(api_data.content)
    #Connect with variables
    lu_date= api_json['data']['update_date_time']
    lu_cases= api_json['data']['local_new_cases']
    lu_total= api_json['data']['local_total_cases']
    lu_hospital= api_json['data']['local_total_number_of_individuals_in_hospitals']
    lu_deaths= api_json['data']['local_deaths']
    lu_recover= api_json['data']['local_recovered']
    lu_rate1=round((lu_deaths/lu_recover)*100)

    #Put them into lables
    lbl_topic=Label(root,text="Covid-19 Live Update - Sri Lanka \n", font="Helvatica 19 bold")
    lbl_topic.grid(row=0,column=0,columnspan=2)
    lbl_1=Label(root,text="Cases as at ", font="Helvatica 12 bold")
    lbl_1.grid(row=1,column=0)
    lbl_2=Label(root,text=lu_date, font="Helvatica 12")
    lbl_2.grid(row=1,column=1)
    lbl_3=Label(root,text="New cases for today", font="Helvatica 12 bold",fg="#A47118")
    lbl_3.grid(row=2,column=0)
    lbl_4=Label(root,text=lu_cases, font="Helvatica 12 bold",  fg="#A47118")
    lbl_4.grid(row=2,column=1)
    lbl_5 = Label(root, text="Total Cases ", font="Helvatica 12 bold", fg="#BF0E23")
    lbl_5.grid(row=3, column=0)
    lbl_6 = Label(root, text=lu_total, font="Helvatica 12 bold", fg="#BF0E23")
    lbl_6.grid(row=3, column=1)
    lbl_7 = Label(root, text="Number of person hospitalized ", font="Helvatica 12 bold",fg="#C2C805")
    lbl_7.grid(row=4, column=0)
    lbl_8 = Label(root, text=lu_hospital, font="Helvatica 12 bold",fg="#C2C805")
    lbl_8.grid(row=4, column=1)
    lbl_9 = Label(root, text="Total Deaths ", font="Helvatica 12 bold", fg="#A00329")
    lbl_9.grid(row=5, column=0)
    lbl_10 = Label(root, text=lu_deaths, font="Helvatica 12 bold",fg="#A00329")
    lbl_10.grid(row=5, column=1)
    lbl_11 = Label(root, text="Total Recovered ", font="Helvatica 12 bold", fg="#009E37")
    lbl_11.grid(row=6, column=0)
    lbl_12 = Label(root, text=lu_recover, font="Helvatica 12 bold",fg="#009E37")
    lbl_12.grid(row=6, column=1)
    lbl_13 = Label(root, text="Death rate WRT closed cases ", font="Helvatica 12 bold", fg="#0C1427")
    lbl_13.grid(row=7, column=0)
    lbl_14 = Label(root, text=str(lu_rate1)+"%", font="Helvatica 12 bold",fg="#0C1427")
    lbl_14.grid(row=7, column=1)
    lbl_15 = Label(root,text="Contact developer -  chinthakaasiri@gmail.com", font="Helvatica 7")
    lbl_15.grid(row=9,column=0,columnspan=2)

    #Button
    ext_btn=Button(root, text="Exit", command=root.destroy,bg="red",fg="white",font="Helvatica 12 bold",padx=25)
    ext_btn.grid(row=8,column=0,columnspan=2)


except Exception as e:
    api_json="Please check your internet connection. "
    lbl_err = Label(root, text=api_json, font="Helvatica 12 bold",fg="#0C1427")
    lbl_err.grid(row=0,column=0,columnspan=2)
    lbl_16 = Label(root,text="Contact developer -  chinthakaasiri@gmail.com", font="Helvatica 7")
    lbl_16.grid(row=2,column=0,columnspan=2)
    #Button
    ext_btn_e=Button(root, text="Exit", command=root.destroy,bg="red",fg="white",font="Helvatica 12 bold",padx=25)
    ext_btn_e.grid(row=1,column=0,columnspan=2)


root.mainloop()
