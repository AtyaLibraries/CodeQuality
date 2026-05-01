# C# Coding Style

The general rule we follow is **"use Visual Studio defaults"** unless this policy says otherwise.

## Rule mapping

This document separates rules into:

- **Enforced by `.editorconfig`** (repo-local formatting/editor behavior)
- **Enforced by `.globalconfig`** (shared analyzer/code-style policy)
- **Enforced by `stylecop.json`** (StyleCop-specific behavior)
- **Documented only** (human review or future custom analyzer)

## Rules

1. **Allman style braces** - enforced by repo `.editorconfig` for formatting; the nuanced single-line-if exceptions remain **documented only**.
2. **Four spaces, no tabs** - enforced by repo `.editorconfig`.
3. **Field naming** (`_camelCase`, `s_`) and `readonly` where possible - enforced in `.globalconfig`; `[ThreadStatic]` `t_` naming is documented only until a custom analyzer can distinguish it from normal static fields.
4. **Avoid `this.` unless necessary** - enforced in `.globalconfig`; StyleCop's opposite `SA1101` rule is disabled.
5. **Always specify visibility, visibility first** - enforced in `.globalconfig`.
6. **Using directives outside namespace, `System.*` first** - enforced in `stylecop.json` + `.globalconfig` severity.
7. **Avoid more than one empty line** - best-effort via analyzer severity; keep as team guidance.
8. **Avoid spurious free spaces** - enforced by repo `.editorconfig`.
9. **If a file already differs in style, the file-local existing style wins** - documented only.
10. **`var` is permitted when the type is obvious** - documented only; stock analyzers do not model the rule exactly.
11. **Prefer C# keywords over BCL type names** - enforced in `.globalconfig`.
12. **PascalCase constant names** - enforced in `.globalconfig`; interop exception is documented only.
13. **PascalCase for method names and local functions** - enforced in `.globalconfig`.
14. **Use `nameof(...)` whenever relevant** - enforced in `.globalconfig`.
15. **Fields at the top of type declarations** - enforced with StyleCop ordering.
16. **Use Unicode escape sequences for non-ASCII source** - documented only.
17. **Indent labels one less than the current indentation** - documented only.
18. **Single-statement `if` conventions** - documented only for the full nuance; a coarse brace/new-line preference is configured in editor settings.
19. **Make private/internal types static or sealed unless derivation is required** - documented only / future custom analyzer.
20. **Primary constructor parameters should use `camelCase` without `_`** - enforced for naming in `.globalconfig`; the "small type vs field assignment" nuance is documented only.
21. **XML documentation and file headers are optional by default** - the package does not enable StyleCop documentation/header rules unless a consuming repository opts into them.
