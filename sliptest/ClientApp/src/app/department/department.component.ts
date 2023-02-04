import { Component, OnInit } from '@angular/core';
import { DepartmentAPIClient, DepartmentDTO } from '../Services/apiservice.service';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrls: ['./department.component.css'],
  providers:[DepartmentAPIClient]
})
export class DepartmentComponent implements OnInit {

  constructor(private service: DepartmentAPIClient) { }
  department: DepartmentDTO[] = []
  ngOnInit(): void {
    this.getdepartment()
  }


  getdepartment() {
    this.service.getAllDepartment().subscribe(res => {
      this.department = res;
    })
  }
  deletedepartment(id: any) {
    this.service.deleteDepartment(id).subscribe((res) => {
    })
  }

}
