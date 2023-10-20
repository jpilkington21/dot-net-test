# Maintenance Task Workbench

The Maintenance Task workbench is used as part of daily planning meetings to determine what work needs to be performed on aircraft that day. 

## Prerequisites

- Visual Studio, Visual Studio Code or Rider
- .NET 6 SDK (or later)

## What you need to do

An existing developer has moved team without completing their sprint tasks!

This is the relevant user story:

> As a user
>
> I want to see all Maintenance Tasks that are up to 7 days in the future
>
> So that I know what work I need to perform on the aircraft

This is the acceptance criteria:

> GIVEN I have Maintenance Tasks
>
> WHEN run the workbench tool
>
> THEN I should see all the Maintenance Tasks for 7 days in the future
>
> AND they should be ordered by the next task to complete first (date)
>
> AND they should be displayed in the format: `<ID>: Date Required: <DateRequired>, Task: <MaintenanceCode>-<Description>`

## After you're done

Like all good development teams, we'll be peer reviewing your work after you're done. We'll be asking a few questions around why you decided on your approach, how you might test it, what things you might change in the code you were left with, and so on.