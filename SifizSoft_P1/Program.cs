// See https://aka.ms/new-console-template for more information

using Dumpify;
using Sfz_Repositorio_Examen;
using SifizSoft_P1;
using SifizSoft_P1.Csharp;
using SifizSoft_P1.ExtensionesGenericos;
using SifizSoft_P1.Linq;
using SifizSoft_P1.LogicaFinancial.Entidades;
using RegistroContable = SifizSoft_P1.LogicaFinancial.Entidades.RegistroContable;

Repositorio.CargarDatos<RegistroContable>("RegistrosContablesSanJose.csv");
Repositorio.CargarDatos<PadreDivision>("PadreDivisionesActivosFijos.csv");
Repositorio.CargarDatos<Division>("DivisionesActivosFijos.csv");
Repositorio.CargarDatos<Activo>("ActivosFijos.csv");

new DatoPersona("Tomas Zules", "SifizSoft").Dump();

CuestionarioEG.EgEjercicio1_Puntaje1();
CuestionarioEG.EgEjercicio2_Puntaje1();
await CuestionarioEG.EgEjercicio3_Puntaje3();

CuestionarioLi.LiEjercicio1_Puntaje2();
CuestionarioCs.CsEjemplo1_Puntaje1();

RegistroContable.ConsultaDocumentosRegistrosDescuadrados();
//ProyectoVe.MovimientoVentanilla.ConsultaConsolidada(DateTime.Now.Date);

