import { Component, OnInit } from '@angular/core';
import { DepartmentAPIClient, DepartmentDTO } from '../Services/apiservice.service';

@Component({
  selector: 'app-location',
  templateUrl: './location.component.html',
  styleUrls: ['./location.component.css'],
  providers:[DepartmentAPIClient]
})
export class LocationComponent implements OnInit {
  department :DepartmentDTO[]=[]
  constructor(private service: DepartmentAPIClient) { }

  ngOnInit(): void {

  }

  getdepartment() {
    this.service.getAllDepartment().subscribe(res => {
      this.department = res;
    })
  }
  
}
