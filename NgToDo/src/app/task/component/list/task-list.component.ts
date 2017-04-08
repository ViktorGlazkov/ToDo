import {Component, OnInit} from '@angular/core';
import {TaskService} from '../../task.service';

@Component({
  selector: 'app-task-list',
  templateUrl: './task-list.component.html'
})

export class TaskListComponent implements OnInit {
  public taskList = [];

  private taskService: TaskService;

  constructor(taskService: TaskService) {
    this.taskService = taskService;
  }

  ngOnInit(): void {
    this.updateTaskList();
  }

  public updateTaskList() {
    this.taskService.updateTaskList().subscribe(response => {
      this.taskList = response.json();
    });
  }
}
