﻿namespace iTec_project.Base;

public interface IModel
{
    string Id { get; set; }

    DateTime Created { get; set; }

    DateTime Updated { get; set; }
}