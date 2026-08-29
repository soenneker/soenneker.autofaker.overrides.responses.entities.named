[![](https://img.shields.io/nuget/v/soenneker.autofaker.overrides.responses.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.responses.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.responses.entities.named/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.responses.entities.named/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.autofaker.overrides.responses.entities.named.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.autofaker.overrides.responses.entities.named/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.autofaker.overrides.responses.entities.named/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.autofaker.overrides.responses.entities.named/actions/workflows/codeql.yml)

# Soenneker.AutoFaker.Overrides.Responses.Entities.Named

An AutoFaker override that supplies a display name for `NamedEntityResponse` models.

## Installation

```bash
dotnet add package Soenneker.AutoFaker.Overrides.Responses.Entities.Named
```

## Usage

```csharp
using Soenneker.AutoFaker.Overrides.Responses.Entities.Named;
using Soenneker.AutoFaker.Overrides.Responses.Entity;
using Soenneker.Responses.Entities.Named;
using Soenneker.Utils.AutoBogus;

var autoFaker = new AutoFaker();
autoFaker.Config.Overrides =
[
    new EntityResponseOverride(),
    new NamedEntityResponseOverride()
];

NamedEntityResponse response = autoFaker.Generate<NamedEntityResponse>();
```

The named override fills `Name` with a commerce product name and applies to derived response types. Pair it with `EntityResponseOverride` to produce coherent inherited identity and timestamps.
