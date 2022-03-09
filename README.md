# CleanGraphQL
Cleanarchitecture based project with graphql

# Setup
CLI : Execute "dotnet ef database update" inside the Mediator.Api project.

VS : Open the solution and execute "update-database" inside the package manager console.

# Usage 
Open the following path in your browser or in a graphql playground app: 
https://localhost:7075/graphql 


First you'll need to create a user with the following mutation : 
>
     mutation testMutation {
        add(command: {
          email: "test"
          firstName: "1234"
          lastName: "myname"
          password: "1234"
          username: "goodUser"
        }
      )
    }




You can execute the following query to test the creation of the user : 
>
    query testQuery {
      userByKey(input: { id: 1 }) {
          username
       }
     }
