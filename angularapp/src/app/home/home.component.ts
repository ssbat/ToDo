import { Component, OnInit } from '@angular/core';
import { TaskService } from '../shared/services/Task.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{
  constructor(private _taskService:TaskService) {
  console.log("i am created")
  }
  ngOnInit(): void {
      // this._taskService.getTasks().subscribe();
      this._taskService.getTaskById(3).subscribe();

  }
}
