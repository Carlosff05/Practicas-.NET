namespace PracticasModulo6_Genericos;

public class AccionPersona<TPersona, TReferencia>
where TReferencia : struct 
where TPersona : IContribuyente<int>
{
    private TReferencia _refInterna = default(TReferencia);
    
    public TReferencia Referencia { get; set; }
    public TPersona Persona { get; set; }

    public bool EsIgual(TPersona OtraPersona)
    {
        return OtraPersona.Contribuye();
    }
}