# API
This is my ADK coding exercise to convert the login and feed controllers to .NET specifically the verification_controller and the feed_controller from tradehounds_api. **One assumption I'm making is that it's OK to use a new database.**


**My Time estimate for this is 3-4 hours** 


There will be some research needed while working on this project because not all the packages in elixir are avaiable for .NET 
 like timex, I believe I can use nodatime in dotnet though, and imagemagic but I don't think I'll need that software for this phase of the project.
 
 
To keep an eye on my progress you can watch the commits on this branch or track my status on trello(https://trello.com/b/aZEy1inO). In trello I have the tasks to begin my conversion.

**End Points**
## /api/v1/users/:id/verifications
#### POST /api/v1/users/:id/verifications
##### Request
* __Method:__ POST
* __Path:__ /api/v1/users/1/verifications
* __Request headers:__
```
accept: application/json
```
* __Request body:__
```json
{
    "type": "verifications",
    "attributes": {
      "pin": "1234"
    }
}
```

##### Response
* __Status__: 201
* __Response headers:__
```
content-type: application/json
```
* __Response body:__
```json
{
  "type": "verifications",
  "attributes": {
    "user_id": 1,
    "jwt": "fake_jwt"
  }
}
```
## /api/v1/users/:id/feeds
### <a id=api-v1-users-id-feeds-index></a>index
#### GET /api/v1/users/:id/feeds
##### Request
* __Method:__ GET
* __Path:__ /api/v1/users/7967/feeds


