import { Component, OnInit } from '@angular/core';
import { WorkshopUser, RunningWorkshopModel } from '../../models/runningWorkshop.model'

@Component({
  selector: 'app-running-workshop',
  templateUrl: './running-workshop.component.html',
  styleUrls: ['./running-workshop.component.scss'],
  host: {'class': 'flex flex-grow'}
})
export class RunningWorkshopComponent implements OnInit {

  model: RunningWorkshopModel

  constructor() { 
    // Example model
    this.model = {
      title: 'Example workshop',
      users: [
        {
          name: 'Non-voted user name',
          connected: true,
          voted: false
        } as WorkshopUser,
        {
          name: 'Voted user name',
          connected: true,
          voted: true
        } as WorkshopUser,
        {
          name: 'Disconnected user name',
          connected: false,
          voted: false
        } as WorkshopUser
      ]
    } as RunningWorkshopModel;
  }

  ngOnInit(): void {
  }

}
