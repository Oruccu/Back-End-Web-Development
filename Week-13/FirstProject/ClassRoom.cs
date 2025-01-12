﻿using System;

namespace Company.ClassLibrary1;

public class ClassRoom
{
    private readonly IOgretmen _teacher;

    public ClassRoom(IOgretmen teacher)
    {
        _teacher = teacher;
    }

    public string GetTeacherInfo()
    {
        return _teacher.GetInfo();
    }
}