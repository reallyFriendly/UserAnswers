﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SticksyProtocol;
using BaseProtocol;

namespace UserAnswers
{
    class UserAnswers // Ответы на запросы по юзеру
    {
        public AnswerId SignUp(Sign newUser) // SignUp(Регистрация)
        {
            StiksyDataBase DBquery = new StiksyDataBase();
            // Возвращает id нового User или -1, если такой пользователь уже занят
            return new AnswerId(DBquery.CreateUser(newUser.login, newUser.password), TypeId.IdUser);
        }
        public AnswerUser SignIn(Sign checkUser) // SignIn(Авторизация)
        {
            StiksyDataBase DBquery = new StiksyDataBase();
            // Возвращает объект User или null, если нет совпадений в базе
            return new AnswerUser(DBquery.GetUserByLoginPassword(checkUser.login, checkUser.password));
        }

    }
}
