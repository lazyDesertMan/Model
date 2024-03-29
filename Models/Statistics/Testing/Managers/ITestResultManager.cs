﻿using Model.Models.User;
using Model.Models.Work;
using System.Collections.Generic;

namespace Model.Models.Statistics.Testing
{
    /*******************************************************\
    ИНТЕРФЕЙС.: ITask
    ОПИСАНИЕ..: Интерфейс классов, выполняющих работу со
                статистикой тестирований.
    МЕТОДЫ....: void Save(TestResult Result) - сохранение
                   результата теста.
                TestResult Score(int TestID, int UserID) -
                   возвращает результат указанного пользователя,
                   полученный в указанном тесте.
                List<TestResult> UserScores(int UserID) - 
                   возвращает баллы указанного
                   пользователя, набранные во всех тестах.
                List<TestResult> TestScores (int TestID) -
                   возвращает баллы пользователей,
                   выполнивших указанный тест.
    \*******************************************************/
    public interface ITestResultManager
    {
        /*******************************************************\
        МЕТОД.....: Save
        ОПИСАНИЕ..: Сохранение результата теста.
        ПАРАМЕТРЫ.: TestResult Result - результат
        \*******************************************************/
        void Save(CTestResult Result);

        /*******************************************************\
        МЕТОД.....: GetResult
        ПАРАМЕТРЫ.: int TestID - ID теста
                    int UserID - ID пользователя
        ОПИСАНИЕ..: Возвращает результат указанного пользователя,
                    полученный в указанном тесте.
        ВОЗВРАТ...: TestResult - результат теста
        \*******************************************************/
        CTestResult GetResult(int TestID, int UserID);

        /*******************************************************\
        МЕТОД.....: UserScores
        ОПИСАНИЕ..: Возвращает все результаты пользователя.
        ПАРАМЕТРЫ.: int UserID - ID пользователя.
        ВОЗВРАТ...: Статистика пользователя
        \*******************************************************/
        List<CUserStatistic> UserStatistic(int UserID, IWorkFinder workFinder);

        /*******************************************************\
        МЕТОД.....: TestScores
        ОПИСАНИЕ..: Возвращает все результаты теста
        ПАРАМЕТРЫ.: int TestID - ID теста.
        ВОЗВРАТ...: List<TestResult> - результаты теста.
        \*******************************************************/
        CTestStatistic TestStatistic(int TestID, IUserFinder userFinder);
    }
}
