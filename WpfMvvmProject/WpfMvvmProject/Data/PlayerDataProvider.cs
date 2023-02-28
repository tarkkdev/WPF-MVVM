﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMvvmProject.Interface;
using WpfMvvmProject.Model;

namespace WpfMvvmProject.Data;

public class PlayerDataProvider : IPlayerDataProvider
{
    public async Task<IEnumerable<Player>?> GetPlayerDataAsync()
    {
        //simulate long running task
        await Task.Delay(1000);

        return new List<Player>()
        {
            new Player{Id=1, FirstName="Michael", LastName="Jorda", Position="Shooting Gurad", IsRetired=true},
            new Player{Id=2, FirstName="Shaquille", LastName="O'neal", Position="Center", IsRetired=true },
            new Player{Id=3, FirstName="LeBron", LastName="James", Position="Power Forward", IsRetired=false},
            new Player{Id=4, FirstName="Kevin", LastName="Durant", Position="Small Forward", IsRetired=false},
            new Player{Id=5, FirstName="Magic", LastName="Johnson", Position="Point Guard", IsRetired=true}
        };
    }
}
