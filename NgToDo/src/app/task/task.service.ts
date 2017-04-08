import { Injectable } from '@angular/core';
import { TaskProvider } from './task.provider';

@Injectable()
export class TaskService {
  private taskProvider: TaskProvider;

  constructor(taskProvider: TaskProvider) {
    this.taskProvider = taskProvider;
  }

  public updateTaskList() {
    return this.taskProvider.updateTaskList();
  }

  public getTask() {
    return this.taskProvider.updateTaskList();
  }
}
