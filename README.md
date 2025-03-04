# ASP.NET Core - Middleware Tutorial
This application is the application created at the end of the MS guided learning on ASP.NET Core. It is considered beginner-level knowledge and is presented here for anyone interested in the course.

## Purpose

The purpose of the ASP.NET apps published by Primis Solutions is to demonstrate to viewers the level of proficiency of the developers at the company.

This repository is considered beginner-level, and is provided purely for completeness.

## Lessons Learned
This section notes any lessons learned as part of undertaking this project, for any viewers or Primis associates who are interested in project logs. As this was an extremely minimal project, no significant lessons were learned.

### Tips
* Custom middleware behaves differently depending on the order in which it is called in the middleware pipeline. It can also behave differently depending on where in the code you await the next middleware pipeline's actions.
