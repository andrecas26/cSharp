﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Todoapp
{
    class App
    {
        ItemRespository repo;
        public App()
        {
            repo = new ItemRespository();
        }
        public void start()
        {
            // 1. Display Menu
            string  action ="";

            // 2. Process user actions
            while (action != "9")
            {
                // use switch or if
                //If action == 
                // Ask ItmeRespository to return a list of ToDoItem objects
                // ask consoleUtils to display the list
                // break
                if (action == "1")
                {
                    List<Todoitem> list = repo.GetToDoItems();
                    ConsoleUtils.PrintToDoItems(list);
                    continue;
                }
                if (action == "2")// add a new item
                {
                    List<Todoitem> list2 = repo.AddItem();
                    ConsoleUtils.PrintToDoItems(list2);
                    continue;
                }
                if (action == "3") // update an item
                    {

                        List<Todoitem> list3 = repo.updateItem();
                        ConsoleUtils.PrintToDoItems(list3);
                        continue;
                    }
                if (action == "4") // delete an item
                    {
                        List<Todoitem> list4 = repo.DeleteItem();
                        ConsoleUtils.PrintToDoItems(list4);
                        continue;
                    }
                    if (action == "9")
                        break;
                    action = ConsoleUtils.PrintMenu();
                }
                
                // if action is to create a new iem 
                // ask consoleutils to get the item infro from the user
                // ask itemrepository to create a new todoItem
                // ask consoleutils to display the current list

            }
        }
    }

