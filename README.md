# Cshar CodeQL Repros

Public repo to demonstrate an issue with the CodeQL logging as described in [codeql/issues/15824](https://github.com/github/codeql/issues/15824).

## Warning
It is triggering warnings like this:
* `cs/log-forging` (CWE-117)
* Severity: High
* OWASP: Log Injection.
* Common Weakness Enumeration: CWE-117.

## References
* CodeQL query: [csharp/ql/src/Security Features/CWE-117/LogForging.ql](https://github.com/github/codeql/blob/975881c74a74d3965e1690c9c24d82b581336b0c/csharp/ql/src/Security%20Features/CWE-117/LogForging.ql)
