﻿using System.Collections.Generic;

namespace Model.Models.User
{
    /********************************************************************\
    ПЕРЕЧИСЛЕНИЕ: EUserType
    ОПИСАНИЕ....: Типы пользовательский аккаунтов
    ЗНАЧЕНИЯ....: UT_ADMIN = 0 - аккаунт администратора
                  UT_STUDENT = 1 - аккаунт обучающегося
                  UT_TEACHER = 2 - аккаунт преподавателя
    \********************************************************************/
    public enum EUserType
    {
        UT_ADMIN   = 0, // Администратор
        UT_STUDENT = 1, // Обучающийся
        UT_TEACHER = 2  // Преподаватель
    }
}
