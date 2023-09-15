import Repository from "../Repository";

const resource = 'DonViQuanLiXe'

export default {
    getAll(){
        return Repository.get(`${resource}`)
    }
}