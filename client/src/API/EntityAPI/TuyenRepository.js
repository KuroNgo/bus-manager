import Repository from "../Repository";

const resource = 'Tuyen';

export default {
    getTuyen(version) {
        return Repository.get(`${version}/${resource}`);
    }
    
}