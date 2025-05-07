namespace RedoCapstone
{
    public interface IHasAttributes
    {

        int GetDexterityScore();
        int GetConstitutionScore();
        int GetWillpowerScore();

        int BaseDexterityScore { set; get; }
        int BaseConstitutionScore { set; get; }
        int BaseWillpowerScore { set; get; }

    }
}
