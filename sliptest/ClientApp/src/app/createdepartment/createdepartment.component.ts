import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AddDepartmentDTO, DepartmentAPIClient, DepartmentDTO } from '../Services/apiservice.service';

@Component({
  selector: 'app-createdepartment',
  templateUrl: './createdepartment.component.html',
  styleUrls: ['./createdepartment.component.css'],
  providers: [DepartmentAPIClient]
})
export class CreatedepartmentComponent implements OnInit {
  adddepartment: AddDepartmentDTO = new AddDepartmentDTO
  department!: DepartmentDTO
  depatmentid: any;
  constructor(private service: DepartmentAPIClient, private route: ActivatedRoute,
    private router: Router,) { }

  ngOnInit(): void {
    this.route.params.subscribe((params) => {

      if (params.id) {
        this.depatmentid = params.id;
        this.getDepartmentbyid()
      }
    })
  }
  save() {
    if (this.depatmentid) {

      var updatedepartment = new DepartmentDTO()
      updatedepartment.pkDepartmentId = this.depatmentid;
      updatedepartment.jobCode = this.adddepartment.jobCode;
      updatedepartment.title = this.adddepartment.title;
      this.service.updateDepartment(updatedepartment).subscribe((res => {
        this.router.navigate(["/admin/department"])
      }))
    }


    else {
      this.service.addDepartment(this.adddepartment).subscribe((res => {
      }))
    }
  }

  getDepartmentbyid() {

    this.service.getDepartmentById(this.depatmentid).subscribe((res) => {
      this.department = res;
      this.adddepartment.isActive = this.department.isActive
      this.adddepartment.jobCode = this.department.jobCode;
      this.adddepartment.description = this.department.description;
    })
  }

}
