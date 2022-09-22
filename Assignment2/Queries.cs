namespace Assignment2;

public class Queries
{
    //
    public IReadOnlyCollection<Wizard> wizards;
    //public IEnumerator<Wizard> wizards = WizardCollection.Create().GetEnumerator();

    // Extension
    public IEnumerable<string> byRowlingExt() {
        if (wizards == null) throw new Exception();
        else return wizards.Where(w => w.Creator.Contains("Rowling")).Select(w => w.Name);
    }

    public IEnumerable<int?> firstSithExt() {
        if (wizards == null) throw new Exception();
        else return wizards.Where(w => w.Name.Contains("Darth")).OrderBy(w => w.Year).Select(w => w.Year).Take(1);
    }

    public IEnumerable<(string, int?)> uniqHPExt() {
        if (wizards == null) throw new Exception();
        else return wizards.Where(w => w.Medium.Contains("Harry Potter")).Select(w => (w.Name, w.Year));
    }

    public IEnumerable<string> wizRevExt() {
        if (wizards == null) throw new Exception();
        else {
            var listWiz = wizards.OrderBy(w => w.Name).GroupBy(w => w.Creator).OrderByDescending(w => w.Key).Select(w => w);
            foreach (var wLst in listWiz)
            {
                foreach (var w in wLst)
                {
                    yield return w.Name;
                }
            }
        }
    }

    // LINQ
    public IEnumerable<string> byRowling() {
        var names =
            from w in wizards
            where w.Creator.Contains("Rowling")
            select w.Name;
        return names;
    }

    public IEnumerable<int?> firstSith() {
        var year = (
            from w in wizards
            where w.Name.Contains("Darth")
            orderby w.Year
            select w.Year).Take(1);
        return year;
    }

    public IEnumerable<(string, int?)> uniqHP() {
        var listHP =
            from w in wizards
            where w.Medium.Contains("Harry Potter")
            select (w.Name, w.Year);
        return listHP;
    }

    public IEnumerable<string> wizRev() {
        var listWiz =
            from w in wizards
            orderby w.Name
            group w by w.Creator into creator
            orderby creator.Key descending
            select creator;
        foreach (var wLst in listWiz)
        {
            foreach (var w in wLst)
            {
                yield return w.Name;
            }
          
        }
    }
}
