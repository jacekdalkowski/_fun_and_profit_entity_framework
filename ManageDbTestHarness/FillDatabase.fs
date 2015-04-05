

module FillDatabase 

    open System
    open System.Data
    open System.Data.Linq
    open Microsoft.FSharp.Data.TypeProviders
    open Microsoft.FSharp.Linq

    type dbSchema = SqlDataConnection<"Data Source=win-f7uski20bnv\sqlexpress;Initial Catalog=ef_put_employees_code_first;Integrated Security=True;MultipleActiveResultSets=true;">

    let private createPositions (db : dbSchema.ServiceTypes.SimpleDataContextTypes.Ef_put_employees_code_first) =
        db.Positions.InsertOnSubmit(new dbSchema.ServiceTypes.Positions(
                                                     Name = "DYREKTOR", 
                                                     SalaryMin = 10000m,
                                                     SalaryMax = 15000m))

        db.Positions.InsertOnSubmit(new dbSchema.ServiceTypes.Positions(
                                                     Name = "PROFESOR", 
                                                     SalaryMin = 8000m,
                                                     SalaryMax = 12000m))

        db.Positions.InsertOnSubmit(new dbSchema.ServiceTypes.Positions(
                                                     Name = "ASYSTENT", 
                                                     SalaryMin = 4000m,
                                                     SalaryMax = 6000m))

        db.Positions.InsertOnSubmit(new dbSchema.ServiceTypes.Positions(
                                                     Name = "TECHNICZNY", 
                                                     SalaryMin = 2000m,
                                                     SalaryMax = 4000m))


    let fillWithMockData = 
        
        let db = dbSchema.GetDataContext()

        // Enable the logging of database activity to the console.
        db.DataContext.Log <- System.Console.Out

        createPositions db

        try
            db.DataContext.SubmitChanges()
            printfn "Successfully inserted new rows."
        with
           | exn -> printfn "Exception:\n%s" exn.Message


    