import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { environment } from "src/environments/environment.development";

@Injectable({
    providedIn: "root"
})
export class TaskService{
    endpoint:string="/api/task";
    constructor(private _http:HttpClient){

    }

    getTasks():Observable<any> {
        return this._http.get(this.endpoint);
    }
    getTaskById(id:number):Observable<any> {
        return this._http.get(this.endpoint+"/"+id);
    }
}