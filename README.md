# cleanco C# - clean organization names

## What is it / what does it do?

This is a C# library port of the original Python package that processes company names, providing cleaned versions of the
names by stripping away terms indicating organization type (such as "Ltd." or "Corp").

Using a database of organization type terms, It also provides an utility to deduce the
type of organization, in terms of US/UK business entity types (ie. "limited liability
company" or "non-profit").

Finally, the system uses the term information to suggest countries the organization could
be established in. For example, the term "Oy" in company name suggests it is established
in Finland, whereas "Ltd" in company name could mean UK, US or a number of other
countries.

## How do I install it?
Download it from this site and unzip the directory or get the package (https://www.nuget.org/packages/cleanco/)

* Windows: Open the .sln file in a suitable Windows IDE (I use Visual Studio 2013)

## How does it work?
Let's look at some sample code.
Prepare a string of a company name that you want to process:

    string businessName = "Some Big Pharma, LLC";

Throw it into a new instance:

    var cleaner = new cleanco.CompanyCleaner(businessName);

You can now get the company types:

    string[] types = x.Type();
    (Displays {"Limited Liability Company"})

...the possible countries...

    string[] countries = x.country()
    (Displays {"United States of America", "Philippines"})

...and a clean version of the company name.

    string cleanName = x.CleanName();
    (Displays "Some Big Pharma")

## Are there bugs?
You better believe it.  Please let me know or fork this project.  I'm sure some of the company suffixes are way incorrect and I'm missing a lot more information.

## Special thanks to:

- Wikipedia's [Types of Business Entity article](http://en.wikipedia.org/wiki/Types_of_business_entity), where I spent hours of research.
- Contributors: Petri Savolainen <petri.savolainen@koodaamo.fi>
- C# port - Ivan Cronyn <ivan.cronyn@gmail.com>
