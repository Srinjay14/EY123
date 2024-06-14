import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-todo-list',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './todo-list.component.html',
  styleUrl: './todo-list.component.css'
})
export class TodoListComponent {
  tasks: { description: string, completed: boolean }[] = [
    { description: 'Workout', completed: false },
    { description: 'Buy Groceries', completed: false },
    { description: 'Complete Project', completed: false }
  ];
  newTask = '';

  editTask(task: { description: string, completed: boolean }) {
    const updatedTask = prompt('Edit task: ', task.description);
    if (updatedTask !== null) {
      const index = this.tasks.indexOf(task);
      if (index !== -1) {
        this.tasks[index].description = updatedTask;
      }
    }
}

  deleteTask(task: { description: string, completed: boolean }) {
    const index = this.tasks.indexOf(task);
    if(index != -1) {
      this.tasks.splice(index, 1);
    }
  }

  addTask(){
    if (this.newTask.trim()) {
      this.tasks.push({ description: this.newTask, completed: false });
      this.newTask = ''
    }
  }

  isComplete = false;

  toggleCompletion(event: any, task: { description: string, completed: boolean }) {
    task.completed = event.target.checked;
}

}
