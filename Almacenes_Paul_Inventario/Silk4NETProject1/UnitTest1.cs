using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SilkTest.Ntf;
using SilkTest.Ntf.Wpf;
using SilkTest.Ntf.WindowsForms;

namespace Silk4NETProject1
{
    [SilkTestClass]
    public class UnitTest1
    {
        private readonly Desktop _desktop = Agent.Desktop;

        [TestInitialize]
        public void Initialize()
        {
            BaseState baseState = new BaseState();
            baseState.Execute();
        }

        [TestMethod]
        public void TestMethod1()
        {
            WPFWindow almacenes_Paul_InventarioMicrosoftVisualStudio = _desktop.WPFWindow("Almacenes_Paul_Inventario - Microsoft Visual Studio");
            almacenes_Paul_InventarioMicrosoftVisualStudio.SetActive();
            almacenes_Paul_InventarioMicrosoftVisualStudio.WPFMenuItem("Iniciar").Click(MouseButton.Left, new Point(40, 14));

            FormsWindow login = _desktop.FormsWindow("Login");
            login.TextField("txtLoginUsuario").SetPosition(new TextPosition(0, 0));
            login.TextField("txtLoginUsuario").SetText("cristhiano");
            login.TextField("txtLoginUsuario").TypeKeys("<Tab>");
            login.TextField("txtLoginContraseña").TypePasswordKeys("tBItQQ==");
            login.PushButton("btnLoginIngresar").Select();
        }
    }
}