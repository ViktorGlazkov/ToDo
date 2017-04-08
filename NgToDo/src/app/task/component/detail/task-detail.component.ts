import {Component, OnInit} from '@angular/core';
import {TaskService} from '../../task.service';
import {ActivatedRoute} from '@angular/router';

@Component({
  selector: 'app-task-detail',
  templateUrl: './task-detail.component.html'
})

export class TaskDetailComponent implements OnInit{
  public task: any;

  private taskService: TaskService;
  private route: ActivatedRoute;

  constructor(taskService: TaskService, route: ActivatedRoute) {
    this.taskService = taskService;
    this.route = route;
  }

  ngOnInit(): void {
  }

  public getTask() {
    this.taskService.updateTaskList().subscribe(response => {
      this.task = response.json();
    });
  }
}
