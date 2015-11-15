﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

[DataContract, KnownType(typeof(DateTime))]
public class Process
{
    public int id;
    public string code;
    public int quantity;
    public int waste;
    public DateTime start;
    public DateTime change;
    public bool complete;

    public Process(int id, string code, DateTime start, DateTime change, bool complete = false, int quantity = 0, int waste = 0)
    {
        this.id = id;
        this.code = code;
        this.start = new DateTime(start.Ticks, DateTimeKind.Local);
        this.change = new DateTime(change.Ticks, DateTimeKind.Local);
        this.complete = complete;
        this.quantity = quantity;
        this.waste = waste;
    }

    public Process(int id, string code, DateTime start, int quantity = 0, int waste = 0)
    {
        this.id = id;
        this.code = code;
        this.start = new DateTime(start.Ticks, DateTimeKind.Local);
        this.change = this.start;
        this.complete = false;
        this.quantity = quantity;
        this.waste = waste;
    }

    public Process(int id, string code, int quantity = 0, int waste = 0)
    {
        this.id = id;
        this.code = code;
        this.start = new DateTime(DateTime.Now.Ticks, DateTimeKind.Local);
        this.change = this.start;
        this.complete = false;
        this.quantity = quantity;
        this.waste = waste;
    }

    public static void Save(Process process)
    {
        Storage.SetSetting("process", Storage.Serialize(process));
    }

    public static Process Load()
    {
        return Storage.Deserialize<Process>(Storage.GetSetting<string>("process"));
    }
}